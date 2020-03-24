import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@Angular/common/http';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { AppRoutingModule} from './app-routing.module';
@NgModule({
   declarations: [
      AppComponent,
      EventosComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
