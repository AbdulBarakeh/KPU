class MyCustomTag extends HTMLElement {
    connectedCallback() {
        this.innerHTML = '<h2>My custom element</h2><button>click me</button>';
        this.style.backgroundColor = 'blue';
        this.style.padding = '20px';
        this.style.display = 'inline-block';
        this.style.color = 'white';
    }
}
if (!customElements.get('my-custom-tag')) {
    customElements.define('my-custom-tag', MyCustomTag); // Virker ikke i Edge pt
    // use the polyfill https://github.com/WebReflection/document-register-element
}