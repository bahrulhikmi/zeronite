const ENV = {
  dev: {
    apiUrl: 'http://localhost:44373',
    oAuthConfig: {
      issuer: 'http://localhost:44373',
      clientId: 'Infra_App',
      clientSecret: '1q2w3e*',
      scope: 'Infra',
    },
    localization: {
      defaultResourceName: 'Infra',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44373',
    oAuthConfig: {
      issuer: 'http://localhost:44373',
      clientId: 'Infra_App',
      clientSecret: '1q2w3e*',
      scope: 'Infra',
    },
    localization: {
      defaultResourceName: 'Infra',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
