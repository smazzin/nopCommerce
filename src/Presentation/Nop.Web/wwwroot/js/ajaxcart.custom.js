/**
 * Custom AJAX Cart extension for nopCommerce 4.8
 * Adds jQuery UI dialog modal window functionality when a product is added to cart
 */

// Extend the existing AjaxCart with our custom functions
var AjaxCartCustom = {
	init: function () {
			// Create modal container if it doesn't exist
			if ($('#product-added-dialog').length === 0) {
					$('body').append(`
							<div id="product-added-dialog" title="Product Added to Cart" style="display:none;">
									<div id="product-added-info"></div>
									<div class="dialog-buttons">
											<button type="button" id="continue-shopping-button" class="button-1">Continue Shopping</button>
											<a href="/cart" id="view-cart-button" class="button-2">View Cart</a>
											<a href="/checkout" id="checkout-button" class="button-2">Checkout</a>
									</div>
							</div>
					`);

					// Initialize the dialog
					$("#product-added-dialog").dialog({
							autoOpen: false,
							modal: true,
							width: 'auto',
							maxWidth: 500,
							minWidth: 300,
							fluid: true,
							resizable: false,
							draggable: false,
							closeOnEscape: true,
							open: function() {
									// Close dialog when clicking outside
									$('.ui-widget-overlay').on('click', function() {
											$("#product-added-dialog").dialog('close');
									});
									
									// Close dialog when clicking continue shopping button
									$('#continue-shopping-button').on('click', function() {
											$("#product-added-dialog").dialog('close');
									});
							}
					});
			}
			
			// Store original addproducttocart_details function
			this.originalAddToCartFunction = AjaxCart.addproducttocart_details;
			
			// Override the original function
			AjaxCart.addproducttocart_details = this.addproducttocart_details_override;
	},
	
	// Custom override for the add to cart function
	addproducttocart_details_override: function(urladd, formselector) {
			if (AjaxCart.loadWaiting != false) {
					return;
			}
			
			AjaxCart.setLoadWaiting(true);
			
			$.ajax({
					cache: false,
					url: urladd,
					data: $(formselector).serialize(),
					type: 'post',
					success: function(response) {
							if (response.redirect) {
									location.href = response.redirect;
									return true;
							}
							
							if (response.success) {
									// Update top cart and flyout cart sections
									if (response.updatetopcartsectionhtml) {
											$(AjaxCart.topcartselector).html(response.updatetopcartsectionhtml);
									}
									
									if (response.updateflyoutcartsectionhtml) {
											$(AjaxCart.flyoutcartselector).replaceWith(response.updateflyoutcartsectionhtml);
									}
									
									// Show modal with product info
									AjaxCartCustom.showProductAddedModal(response);
							} else {
									// Show error messages
									if (response.message) {
											if (Array.isArray(response.message)) {
													displayNotification(response.message.join('\n'), 'error');
											} else {
													displayNotification(response.message, 'error');
											}
									}
							}
							
							AjaxCart.setLoadWaiting(false);
					},
					error: function(xhr, ajaxOptions, thrownError) {
							console.log(thrownError);
							AjaxCart.setLoadWaiting(false);
					}
			});
	},
	
	// Display the modal with product info
	showProductAddedModal: function(response) {
			var productInfo = '';
			
			if (response.productInfo) {
					// If server returned product info, display it
					productInfo = `
							<div class="product-grid">
									<div class="picture-column">
											<img src="${response.productInfo.picture}" alt="${response.productInfo.name}" class="product-picture"/>
									</div>
									<div class="details-column">
											<h4 class="product-name">${response.productInfo.name}</h4>
											<div class="product-price">Price: <strong>${response.productInfo.price}</strong></div>
											<div class="product-quantity">Quantity: <strong>${response.productInfo.quantity}</strong></div>
											${response.productInfo.attributes ? '<div class="product-attributes">' + response.productInfo.attributes + '</div>' : ''}
									</div>
							</div>
					`;
			} else {
					// Fallback message if no product info
					productInfo = '<p class="success-message">' + response.message + '</p>';
			}
			
			// Update modal content and show it
			$('#product-added-info').html(productInfo);
			$("#product-added-dialog").dialog('open');
			
			// Make dialog responsive
			AjaxCartCustom.makeDialogResponsive();
	},
	
	// Helper method to make the dialog responsive
	makeDialogResponsive: function() {
			// Adjust dialog width based on window size
			var winWidth = $(window).width();
			var dialogWidth = winWidth > 600 ? 500 : winWidth * 0.9;
			
			$("#product-added-dialog").dialog("option", "width", dialogWidth);
			
			// Center dialog
			$("#product-added-dialog").dialog("option", "position", { my: "center", at: "center", of: window });
	}
};

// Initialize our custom cart functions when the document is ready
$(document).ready(function() {
	// Check if jQuery UI is available
	if ($.ui && $.ui.dialog) {
			AjaxCartCustom.init();
			
			// Make dialog responsive when window resizes
			$(window).resize(function() {
					if ($("#product-added-dialog").dialog("isOpen")) {
							AjaxCartCustom.makeDialogResponsive();
					}
			});
	} else {
			console.error("jQuery UI is required for the AJAX cart modal. Please include jQuery UI in your project.");
	}
});