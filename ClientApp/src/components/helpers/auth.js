
  import { Buffer } from 'buffer'

  export const setToken = (token) => {
    window.localStorage.setItem('local-user-Token', token)
  }
  export const setId = (id) => {
    window.localStorage.setItem('local-user-Id', id)
  }

  export const getToken = () => {
    return window.localStorage.getItem('local-user-Token');
  };


  export const getId = () => {
    return window.localStorage.getItem('local-user-Id')
  }

  export const getPayLoad = () => {
    const token = getToken();
    if (!token) return;
    const splitToken = token.split('.');
    if (splitToken.length !== 3) return;
    const payload = JSON.parse(atob(splitToken[1]));
    return payload;
  };

  export function userIsAuthenticated() {
    const token = window.localStorage.getItem('local-user-Token');
    return token !== null;
  }

  export const userIsOwner = (item) => {
    const payload = getPayLoad()
    if (!payload) return
    return payload.userId === item.createdBy 
  }