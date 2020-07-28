class PolySearch extends HTMLElement {
    connectedCallback() {
        this.doSearch();
    }
    doSearch() {
        if (this._apiKey && this._searchTerm) {
            const url = 'https://poly.googleapis.com/v1/assets?keywords=' +
                this._searchTerm + '&format=OBJ&key=' + this._apiKey;
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
            html += '<img src="' + assets[c].thumbnail.url + '" width="200" height="150">';
        }
        this.innerHTML = html;
    }

    set apiKey(value) {
        this._apiKey = value;
        this.doSearch();
    }

    set searchTerm(value) {
        this._searchTerm = value;
        this.doSearch();
    }
}

if (!customElements.get('kpu-poly-search')) {
    customElements.define('kpu-poly-search', PolySearch);
}