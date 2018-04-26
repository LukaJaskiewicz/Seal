﻿import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { HttpParams } from '@angular/common/http';
import { Foo, Bar } from '../models';
import { HopViewModel, TemplateViewModel } from '../models/autogenerated';

@Injectable()
export class HopService {

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) { }

    getFoo(): Foo {
        let result = new Foo();

        return result;
    }
    getHop(hopId: number): HopViewModel {

        let params = new HttpParams()
            .set("id", hopId); 

        this.http.get(this.baseUrl + 'api/Hop/Get', params).subscribe(result => {
            return  result.json() as HopViewModel;
        }, error => console.error(error));
        throw Error;
    }

}
