import { Component, OnInit } from '@angular/core';
import { GridVegetable } from '../../../../viewModels/meal/vegetable';
import { VegetableService } from '../../../../services/meal/vegetable/vegetable.service';

@Component({
  selector: 'vegetable-list',
  templateUrl: './vegetable-list.component.html'
})
export class VegetableListComponent implements OnInit {
  private readonly PAGE_SIZE = 2;
  queryResult: any = {};
  allVegetables: GridVegetable[];
  query: any = {
    pageSize: this.PAGE_SIZE
  };
  columns = [
    { title: 'Id' },
    { title: 'Name', key: 'name', isSortable: true },
    { title: 'Added On', key: 'addedOn', isSortable: true },
    { title: 'Added By', key: 'addedBy', isSortable: true },
    { title: 'Entrees Included', key: 'entreesIncluded', isSortable: true },
    { title: 'Updated On', key: 'updatedOn', isSortable: true },
    {}
  ];

  constructor(private _vegetableService: VegetableService) { }

  ngOnInit() {
    this.populateVegetables();
  }

  private populateVegetables() {
    this._vegetableService.getVegetables(this.query)
      .subscribe(result => {
        this.queryResult = result;
        this.allVegetables = result.items;
      });
  }

  onqueryChange() {
    // Client Side, for small dataset
    /* var queryResult = this.allVegetables;

    if (this.query.vegetableId)
      queryResult = queryResult.query(v => v.keyValuePairInfo.id == this.query.vegetableId);

    this.vegetables = queryResult; */
    this.query.page = 1;
    this.populateVegetables();
  }

  resetquery() {
    this.query = {
      page: 1,
      pageSize: this.PAGE_SIZE
  };
    this.onqueryChange();
  }

  sortBy(columnName) {
    if (this.query.sortBy == columnName) {
      this.query.isSortAscending = !this.query.isSortAscending;
    } else {
      this.query.sortBy = columnName;
      this.query.isSortAscending = true;
    }

    this.populateVegetables();
  }

  onPageChange(_pageIndex) {
    this.query.page = _pageIndex;
    this.populateVegetables();
  }
}
