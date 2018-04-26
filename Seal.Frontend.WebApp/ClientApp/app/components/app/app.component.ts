import { Component } from '@angular/core';
import { HopService } from '../../services/hop.service'
@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [
        HopService
    ]
})

export class AppComponent {
}
