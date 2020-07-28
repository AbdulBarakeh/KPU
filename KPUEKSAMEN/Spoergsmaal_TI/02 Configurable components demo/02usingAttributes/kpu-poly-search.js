// Using attributes
class PolySearch extends HTMLElement {
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
            const url = 'https://poly.googleapis.com/v1/assets?keywords=' +
                this.getAttribute('searchterm') + '&format=OBJ&key=' +
                this.getAttribute('apikey');
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
}

if (!customElements.get('kpu-poly-search')) {
    customElements.define('kpu-poly-search', PolySearch);
}