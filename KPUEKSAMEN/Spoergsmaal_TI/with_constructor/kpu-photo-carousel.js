class PhotoCarousel extends HTMLElement {
    constructor() {
        super();

        var shadow = this.attachShadow({
            mode: 'open'
        });
        var title = document.createElement('h2');
        title.innerHTML = ` ${this.getAttribute('title')}`
        var author = document.createElement('h3');
        author.innerHTML = ` ${this.getAttribute('author')}`

        var image = document.createElement('div');
        image.setAttribute('class', 'image-container');


        var back = document.createElement('button');
        back.setAttribute('class', 'back');
        back.innerHTML = `B`

        var forward = document.createElement('button');
        forward.setAttribute('class', 'forward');
        forward.innerHTML = `F`

        var style = document.createElement('style');
        style.textContent = `
        kpu-photo-carousel {
            position: relative;
            width: 500px;
            height: 300px;
            display: flex;
            padding-top: 10px;
            flex-direction: column;
            border-color: black;
            border-width: 1px;
            border-style: solid;
        }
        
        kpu-photo-carousel h2,
        h4 {
            margin-bottom: 0;
            margin-top: 0;
            margin-left: 10px;
        }
        
        kpu-photo-carousel .image-container {
            margin-top: 15px;
            width: 100%;
            flex: 1;
            background-color: purple;
            background-size: contain;
            background-repeat: no-repeat;
            background-position: 50%;
        }
        
        kpu-photo-carousel button {
            cursor: pointer;
            background: transparent;
            border: none;
            font-size: 48px;
            color: white;
            position: absolute;
            top: 50%;
        }
        
        kpu-photo-carousel button.back {
            left: 10px;
        }
        
        kpu-photo-carousel button.forward {
            right: 10px;
        }
        `
        this._photoposition = 0;
        this._photos = this.getAttribute('photos').split(',');
        this.showPhoto();
        this.back.querySelector('button.back').addEventListener('click', back => this.back(back));
        this.forward.querySelector('button.forward').addEventListener('click', forward => this.forward(forward));

        shadow.appendChild(style);
        shadow.appendChild(title);
        shadow.appendChild(author);
        shadow.appendChild(image);
        shadow.appendChild(back);
        shadow.appendChild(forward);
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