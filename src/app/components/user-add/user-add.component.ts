import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators} from '@angular/forms'

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html',
  styleUrls: ['./user-add.component.css']
})
export class UserAddComponent implements OnInit {

  userAddForm : FormGroup;

  constructor(private formBuilder:FormBuilder) { }

  ngOnInit(): void {
    
    this.createUserAddForm();
    
  }

  createUserAddForm() {
    this.userAddForm = this.formBuilder.group({
      userFirstName:["",Validators.required],
      userLastName:["",Validators.required],
      userEmail:["",Validators.email],
      userPasswordHash:["",Validators.required],
      userPasswordSalt:["",Validators.required],
      userStatus:["",Validators.required]
    })
  }

}