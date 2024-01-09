import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes} from './app-routing.modulo';
import { provideClientHydration } from '@angular/platform-browser';

export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes), provideClientHydration()]
};
