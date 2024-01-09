import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from './User';

const httpOpc = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};

@Injectable({
  providedIn: 'root'
})

export class UsersService {
  url = 'https://localhost:5005/api/user';
  constructor(private http: HttpClient) { }

  GetAll(): Observable<User[]>{
    return this.http.get<User[]>(this.url);
  }
  
}
