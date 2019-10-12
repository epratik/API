import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { User } from './welcome.model';

@Injectable({ providedIn: 'root' })
export class UserService {
    constructor(private http: HttpClient) { }

    register(user: User) {
        console.log(user);
        return this.http.post(`http://localhost:51581/api/user/create`, user);
    }
}