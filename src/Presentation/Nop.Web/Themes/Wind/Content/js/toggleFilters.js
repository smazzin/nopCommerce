function setupFilter(filterSelector) {
  const filter = document.querySelector(filterSelector);
  const filterTrigger = document.querySelector(".mobile-filter-trigger");

  filterTrigger.addEventListener("click", () => {
    toggleFilters(filter);
  });

  document.querySelector(".filters-overlay").addEventListener("click", () => {
    toggleFilters(filter);
  });

  window.onresize = function() {
    if (this.innerWidth > 991) {
      if (filter.classList.contains("active")) {
        toggleFilters(filter);
      }
    }
  };
}

function toggleFilters(filter) {
  filter.classList.toggle("active");
  document.querySelector(".filters-overlay").classList.toggle("active");
}

// Usage
setupFilter(".product-filters");
setupFilter(".sidebar-filters");