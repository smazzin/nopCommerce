import instantsearch from 'instantsearch.js';
import historyRouter from 'instantsearch.js/es/lib/routers/history';
import {
  configure,
  hierarchicalMenu,
  refinementList,
  currentRefinements,
  clearRefinements,
  hits,
  index,
  panel,
  searchBox,
  pagination,
} from 'instantsearch.js/es/widgets';

// import { connectRefinementList } from 'instantsearch.js/es/connectors';

// live search - crawler index
import { searchClient } from "./searchClient";

// const createGroupedRefinementList = connectRefinementList(
//   function renderGroupedRefinementList({ widgetParams, items, refine }) {
//     const container = widgetParams.container;

//     // Clear the container and create a list element
//     container.innerHTML = '';
//     const list = document.createElement('ul');
//     container.appendChild(list);

//     // Populate the list with grouped items
//     items.forEach(item => {
//       const listItem = document.createElement('li');
//       const label = document.createElement('label');
//       const checkbox = document.createElement('input');
//       checkbox.type = 'checkbox';
//       checkbox.checked = item.isRefined;
//       checkbox.value = item.value;

//       // Attach an event listener to the checkbox
//       checkbox.addEventListener('change', () => {
//         refine(item.value);
//       });

//       label.appendChild(checkbox);
//       label.appendChild(document.createTextNode(` ${item.label} (${item.count})`));
//       listItem.appendChild(label);
//       list.appendChild(listItem);
//     });
//   }
// );

// const groupedRefinementList = createGroupedRefinementList({
//   container: document.querySelector('#grouped-refinement-list'),
//   attribute: 'FilterableSpecifications.SpecificationAttributeName',
// });

const brandRefinementList = panel({
  templates: {
    header: 'Brands',
  },
})(refinementList);

const categoryRefinementList = panel({
  templates: {
    header: 'Categories',
  },
})(hierarchicalMenu);

const productSpecificationList = panel({
  templates: {
    header: 'Specifications',
  },
})(refinementList);

// const pageTypeRefinementList = panel({
//   templates: {
//     header: 'Page Types',
//   },
// })(refinementList);

const search = instantsearch({
  indexName: 'Products',
  searchClient,
  future: {
    insights: true,
    preserveSharedStateOnUnmount: true,
  },
  // routing: true,
  routing: {
    stateMapping: {
      stateToRoute(uiState) {
        const indexUiState = uiState['Products'];
        return {
          q: indexUiState.query,
          page: indexUiState.page,
        };
      },
      routeToState(routeState) {
        return {
          'Products': {
            query: routeState.q,
            page: routeState.page || 1, // Default page to 1 if not present
          },
        };
      },
    },
    router: historyRouter({
      windowTitle(routeState) {
        return routeState.q;
      },
      createURL({ qsModule, location, routeState }) {
        const url = location.origin + location.pathname;
        const query = routeState.q ? `?q=${routeState.q}` : '';
        return `${url}${query}`;
      },
      parseURL({ qsModule, location }) {
        const params = qsModule.parse(location.search.slice(1));
        return {
          q: params.q || '',
        };
      },
    }),
  },
});

search.addWidgets([
  configure({
    hitsPerPage: 8,
    clickAnalytics: true,
    userToken: 'user-token',
  }),
  searchBox({
    container: '#searchbox',
  }),
  hits({
    container: '#product-hits',
    cssClasses: {
      root: 'product-grid',
      list: 'item-grid',
      item: 'item-box',
    },
    templates: {
      item: `
      <div
      data-insights-object-id="{{objectID}}"
      data-insights-position="{{__position}}"
      data-insights-query-id="{{__queryID}}"
      class="h-100 product-item">
        <div class="picture">
          <a href="/store/{{ SeName }}" class="d-block">
            <img class="img-fluid" alt="{{ DefaultPictureModel.AlternateText }}" src="{{ DefaultPictureModel.ImageUrl }}" width="280" height="280" />
          </a>
        </div>
        <div class="details">
          <h6 class="product-title">
            <a href="/store/{{ SeName }}">{{#helpers.highlight}}{ "attribute": "Name" }{{/helpers.highlight}}</a>
          </h6>
          <p class="sku">
            {{ Sku }}
          </p>
        </div>
        <div class="add-info">
          <div class="prices">
            <p>{{ ProductPrice.Price }}</p>
          </div>
        </div>
      </div>
    `,
    },
  }),
  currentRefinements({
    container: '#current-refinements',
  }),
  clearRefinements({
    container: '#clear-refinements',
  }),
  categoryRefinementList({
    container: '#categories',
    showParentLevel: true,
    attributes: [
      'FilterableCategories.Name',
    ],
  }),
  brandRefinementList({
    container: '#brands',
    attribute: 'FilterableManufacturers.Name',
  }),
  productSpecificationList({
    container: '#specifications',
    operator: 'and',
    attribute: 'FilterableSpecifications.SpecificationAttributeName',
  }),
  pagination({
    container: '#pagination',
  }),
  // search for pages
  index({ indexName: 'crawler_PC Main' })
  .addWidgets([
    configure({
      hitsPerPage: 8,
    }),
    hits({
      container: '#page-hits',
      cssClasses: {
        root: 'product-grid',
        list: 'item-grid',
        item: 'item-box',
      },
      templates: {
        item: `
        <div class="h-100 product-item">
          <p><a href="{{ path }}">{{#helpers.highlight}}{ "attribute": "title" }{{/helpers.highlight}}</a><p>
          <p>{{#helpers.highlight}}{ "attribute": "description" }{{/helpers.highlight}}<p>
        </div>
      `,
      }
    }),
    // pageTypeRefinementList({
    //   container: '#page-types',
    //   attribute: 'fileType',
    // }),
    // pagination({
    //   container: '#articles-pagination',
    // }),
  ]),
  // groupedRefinementList
]);


search.start();
// console.log(search);