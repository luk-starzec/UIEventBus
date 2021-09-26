
export function scrollIntoView(elementId) {
    var elem = document.getElementById(elementId);
    if (elem === null) return;
    elem.scrollIntoView({ behavior: 'smooth' });
}
