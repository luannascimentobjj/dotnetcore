import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@Angular/common/http';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { AppRoutingModule} from './app-routing.module';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
@NgModule({
   declarations: [
      AppComponent,
      EventosComponent,
      NavComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
