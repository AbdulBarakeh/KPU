// Using attributes
class PolySearch extends HTMLElement {
    connectedCallback() {
        if (this.hasAttribute('thumbheight')) {
            this._thumbheight = this.getAttribute('thumbheight');
            this._thumbwidth = (this.getAttribute('thumbheight') * 1.3333 // aspect ratio
            );
        } else {
            this._thumbheight = 150;
            this._thumbwidth = 200;
        }
        if (this.hasAttribute('backgroundcolor')) {
            this.style.backgroundColor = this.getAttribute('backgroundcolor');
        }
    }

    get searchTerm() {
        return this.getAttribute('searchTerm');
        }
        
    set searchTerm(val) {
        this.setAttribute('searchTerm', val);
        }

    static get observedAttributes() {
        return ['searchterm'];
        //return ['searchterm', 'apikey', 'anotherthing', 'yetanotherthing' ];
    }

    attributeChangedCallback(name, oldval, newval) {
        if (name === 'searchterm') {
            this.doSearch();
        }
    }
    doSearch() {
        if (this.getAttribute('apiKey') && this.getAttribute('searchTerm')) {
            const url = this.getAttribute('baseuri') + '?keywords=' +
                this.getAttribute('searchTerm') + '&format=' + this.getAttribute('format') +
                '&key=' + this.getAttribute('apiKey');
            const request = new XMLHttpRequest();
            request.open('GET', url, true);
            request.addEventListener('load', (event) => {
                this.renderResults(JSON.parse(event.target.response).assets);
            });
            request.send();
        }
    }

    renderResults(assets) {
        let html = '';
        for (let c = 0; c < assets.length; c++) {
            html += '<img src="' + assets[c].thumbnail.url + '" width="' +
                this._thumbwidth + '" height="' + this._thumbheight + '"/>';
        }
        this.innerHTML = html;
    }
}

if (!customElements.get('kpu-poly-search')) {
    customElements.define('kpu-poly-search', PolySearch);
}