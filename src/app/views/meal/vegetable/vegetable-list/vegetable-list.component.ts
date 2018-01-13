import { Router } from '@angular/router';
import { Component, OnInit, ViewChild } from '@angular/core';
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

  @ViewChild('vegetableTable') mainTable: any;
  @ViewChild('entreeTable') detailtable: any;
  @ViewChild('entreeDetailTable') detaildetailtable: any;
  ngx_rows = [];
  ngx_loadingIndicator: boolean = true;
  ngx_reorderable: boolean = true;
  ngx_timeout: any;

  ngx_columns = [
    { prop: 'keyValuePairInfo.id', name: 'Id' },
    { prop: 'keyValuePairInfo.name', name: 'Name' },
    { prop: 'addedOn', name: 'Added On' },
    { prop: 'addedByUserName', name: 'Added By' },
    { prop: 'numberOfEntreeIncluded', name: 'Entrees Included' },
    { prop: 'lastUpdatedByOn', name: 'Updated On' }
  ];


  constructor(private _vegetableService: VegetableService, private router: Router) { }

  ngOnInit() {
    this.populateVegetables();
  }

  private populateVegetables() {
    this._vegetableService.getVegetables(this.query)
      .subscribe(result => {
        this.queryResult = result;
        this.allVegetables = result.items;
        this.ngx_rows = result.totalItemList;
        setTimeout(() => { this.ngx_loadingIndicator = false; }, 1500);
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

  editVegetable(value) {
    console.log('editVegetable value: ' + value);
    this.router.navigate(['/meal/vegetableForm/' + value]);
  }

  onPageMainTable(event) {
    clearTimeout(this.ngx_timeout);
    this.ngx_timeout = setTimeout(() => {
      console.log('onPageMainTable!', event);
    }, 100);
  }

  onPageDetailTable(event) {
    clearTimeout(this.ngx_timeout);
    this.ngx_timeout = setTimeout(() => {
      console.log('onPageDetailTable!', event);
    }, 100);
  }
  
  onPageDetailDetailTable(event) {
    clearTimeout(this.ngx_timeout);
    this.ngx_timeout = setTimeout(() => {
      console.log('onPageDetailDetailTable!', event);
    }, 100);
  }

  toggleExpandRow(row, expanded) {
    console.log('toggleExpandRow Row: ', row);
    console.log('toggleExpandRow expanded: ', expanded);
    let vegeId = row.keyValuePairInfo.Id;
    this.mainTable.rowDetail.toggleExpandRow(row);
  }

  toggleExpandDetailRow(row, expanded) {
    console.log('toggleExpandDetailRow Row: ', row);
    console.log('toggleExpandDetailRow Row expanded: ', expanded);
    let entreeId = row.entreeId;
    this.detailtable.rowDetail.toggleExpandRow(row);
  }

  onDetailToggle(){
    console.log('Detail Toggled', event);
  }

  onDetailDetailToggle(){
    console.log('Detail Detail Toggled', event);
  }
}
