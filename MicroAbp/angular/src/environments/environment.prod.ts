import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'RaviEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44399/',
    redirectUri: baseUrl,
    clientId: 'RaviEcommerce_App',
    responseType: 'code',
    scope: 'offline_access RaviEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44377',
      rootNamespace: 'RaviEcommerce',
    },
  },
} as Environment;
