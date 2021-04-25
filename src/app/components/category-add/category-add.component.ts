import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators} from '@angular/forms'

@Component({
  selector: 'app-category-add',
  templateUrl: './category-add.component.html',
  styleUrls: ['./category-add.component.css']
})
export class CategoryAddComponent implements OnInit {

  categoryAddForm : FormGroup;

  constructor(private formBuilder:FormBuilder) { }

  ngOnInit(): void {

    this.createCategoryAddForm();
    
  }

  createCategoryAddForm() {
    this.categoryAddForm = this.formBuilder.group({
      categoryName:["",Validators.required]
    })
  }

}
