class PhotoCarousel extends HTMLElement {
    connectedCallback() {
        this._photoposition = 0;
        this._photos = this.getAttribute('photos').split(',');
        this.innerHTML = `<h2>${this.getAttribute('title')}</h2>
        <h3>by ${this.getAttribute('author')}</h3>
        <div class='image-container'></div>
        <button class='back'>B</button>
        <button class='forward'>F</button>`;
        this.showPhoto();
        this.querySelector('button.back').addEventListener('click', back => this.back(back));
        this.querySelector('button.forward').addEventListener('click', forward => this.forward(forward));
        this.style.background = 'white';
        this.style.padding = '20px';
    }
    showPhoto() {
        this.querySelector('.image-container').style.backgroundImage = 'url(' +
            this._photos[this._photoposition] + ')';
    }
    forward(forward) {
        if (this._photoposition == this._photos.length) this._photoposition = 0;
        else this._photoposition++;
        this.showPhoto();
    }
    back(back) {
        if (this._photoposition == 0) this._photoposition = this._photos.length;
        else this._photoposition--;
        this.showPhoto();
    }
}
// constructor(){
//     super();
//     this.attachShadow({
//         mode: 'open'
//     });
//     this.shadowRoot.innerHTML = `` 
// }