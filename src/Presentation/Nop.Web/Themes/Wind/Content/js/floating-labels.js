/* Kept it simple with vanilla JS (no external dependencies!) */

/* Get elements that will be manipulated */
//const errorMsg = document.getElementById('form-error');


/* Power up the pretty float labels. Selecting all and running a forEach allows this to scale to as many inputs as needed. If browser has no support for NodeList forEach, classes don't get added, and the fallback is that we have a simple placeholder instead of a float label. */

if (NodeList.prototype.forEach) {
  document.querySelectorAll('input.form-element').forEach(input => {
    input.addEventListener('input', (e) => {
      //errorMsg.innerHTML = ''; // reset email invalid state upon modifying input text
      
      // only toggle float label stuff if label is a float-label
      if (hasClass(e.target.previousElementSibling, 'float-label')) {
        e.target.previousElementSibling.className = (e.target.value.length > 0) ? 'float-label input--filled': 'float-label';
      }
    });
  });
}

/* Shamelessly taken from https://stackoverflow.com/questions/5898656/test-if-an-element-contains-a-class */
function hasClass(element, className) {
    return (' ' + element.className + ' ').indexOf(' ' + className+ ' ') > -1;
}