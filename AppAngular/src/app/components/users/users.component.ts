import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormControl, FormGroup} from '@angular/forms';

@Component({
  selector: 'app-user',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css'],
})

export class UsersComponent {
  public formulario!: FormGroup;
  tituloFormulario: string = "";

  
  constructor (public fb: FormBuilder){
    this.tituloFormulario = "Nova Pessoa"
    this.formulario = this.fb.group({
      nome: new FormControl(null),
      sobrenome: new FormControl(null),
      idade: new FormControl(null),
      profissao: new FormControl(null)
    })
  }

}