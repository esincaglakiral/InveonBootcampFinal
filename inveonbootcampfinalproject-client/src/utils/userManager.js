import { createUserManager } from 'redux-oidc';
import { WebStorageStateStore } from 'oidc-client';

const userStore = new WebStorageStateStore({ store: window.localStorage});
// WebStorageStateStore, kullanıcının oturum durumunu saklamak için kullanılan bir depo (store) oluşturur. 
// Bu depo, localStorage'ı kullanarak tarayıcı sekmesi arasında kullanıcı durumunu saklar. userStore adında 
// bir örneği oluşturulmuştur.

const userManagerConfig = {  //userManagerConfig, kullanıcı yöneticisinin yapılandırma ayarlarını içerir.
  client_id: 'inveon',   //OIDC sunucusunda kayıtlı istemci kimliği.
  redirect_uri: `http://localhost:3000/callback`,  //Kullanıcının kimlik doğrulama sonrası yönlendirileceği URI.
  response_type: 'code',   //Kimlik doğrulama isteği türü.
  client_secret: "secret",  //Güvenli istemci kimliği sırrı.
  scope: 'openid profile',   // Kimlik doğrulama isteğinin kapsamı.
  authority: 'http://localhost:5002',
  silent_redirect_uri: `${window.location.protocol}//${window.location.hostname}${window.location.port ? `:${window.location.port}` : ''}/silent_renew.html`,
  automaticSilentRenew: true,
  loadUserInfo: true,
  userStore: userStore
};

const userManager = createUserManager(userManagerConfig);

export default userManager;

// userManager Export Etme:
// Oluşturulan userManager örneği, diğer dosyalarda kullanılmak üzere export edilir.
//  Bu sayede uygulama genelinde tek bir kullanıcı yöneticisi kullanılabilir.