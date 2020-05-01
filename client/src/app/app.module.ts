import { NgModule } from '@angular/core';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { AppImports, AppComponent, AppDeclarations, AppProviders } from './app.module-generated';
import { WebDataRocksPivot } from "./webdatarocks/webdatarocks.angular4"

@NgModule({
  declarations: [
    ...AppDeclarations, WebDataRocksPivot
  ],
  imports: [
    environment.production ? ServiceWorkerModule.register('ngsw-worker.js') : [],
    ...AppImports
  ],
  providers: [
    ...AppProviders
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
