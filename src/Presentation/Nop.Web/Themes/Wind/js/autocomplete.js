/** @jsxRuntime classic @jsx h */
import { autocomplete, getAlgoliaResults } from '@algolia/autocomplete-js';
// import algoliasearch from 'algoliasearch';
import { h, Fragment } from 'preact';

// import '@algolia/autocomplete-theme-classic';

// live search - crawler index
import { searchClient } from "./searchClient";

autocomplete({
	container: '#autocomplete',
	classNames: {
		root: 'autocomplete',
		input: 'autocomplete-input',
		form: 'autocomplete-form', 
	},
  placeholder: 'Search',
  debug: false,
  // detachedMediaQuery: '', // media query to detach the autocomplete from the input, shows results in modal 
  openOnFocus: false, // true shows results on focus, false shows results on typing
  insights: true,
  plugins: [],

	getSources({ query }) {
    return [
      {
        sourceId: 'products',
        getItems() {
          return getAlgoliaResults({
            searchClient,
            queries: [
              {
                indexName: 'Products',
                query,
                params: {
                  hitsPerPage: 8,
                },
              },
            ],
          });
        },
        getItemUrl({ item }) {
          return item.url;
				},
        templates: {
          header() {
            return (
              <Fragment>
                <span className="aa-SourceHeaderTitle text-dark">Products</span>
                <div className="aa-SourceHeaderLine" />
              </Fragment>
            );
          },
          item({ item, components }) {
            // need to add store/ to the url
            const url = '/store/' + item.SeName;
            return (
              <a href={url} className="aa-ItemLink">
                <div className="aa-ItemContent">
                  <div className="aa-ItemContentBody">
                    <div className="aa-ItemContentTitle">
                      <components.ReverseHighlight hit={item} attribute="Name" />
                    </div>
                    {/* <div className="aa-ItemContentDescription">
                      By <strong>{item.FilterableManufacturers[0].Name}</strong> in{' '}
                      <strong>{item.FilterableCategories[0].Name}</strong>
                    </div> */}
                  </div>
                </div>
              </a>
            );
          },
          noResults() {
            return 'No matching products.';
          },
        },
      },
      {
        sourceId: 'pages',
        getItems() {
          return getAlgoliaResults({
            searchClient,
            queries: [
              {
                indexName: 'crawler_PC Main',
                query,
              },
            ],
          });
				},
        templates: {
          header() {
            return (
              <Fragment>
                <span className="aa-SourceHeaderTitle text-dark">Pages</span>
                <div className="aa-SourceHeaderLine" />
              </Fragment>
            );
          },
          item({ item, components }) {
            return (
              <a href={item.path} className="aa-ItemLink">
                <div className="aa-ItemContent">
                  <div className="aa-ItemContentBody">
                    <div className="aa-ItemContentTitle">
                      <components.Highlight
                        hit={item}
                        attribute="title"
                      />
                    </div>
                  </div>
                </div>
              </a>
            );
          },
          noResults() {
            return 'No matching pages.';
          },
        },
      },

    ];
  },

  // submit to /search?q= with encoded URI component
  onSubmit({ state }) {
    window.location.href = `/search?q=${encodeURIComponent(state.query)}`;
  }
	
});