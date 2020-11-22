import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Infra',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44373',
    redirectUri: baseUrl,
    clientId: 'Infra_App',
    responseType: 'code',
    scope: 'offline_access Infra',
  },
  apis: {
    default: {
      url: 'https://localhost:44373',
      rootNamespace: 'Zeronite.Infra',
    },
  },
} as Config.Environment;
