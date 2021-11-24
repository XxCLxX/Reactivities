export interface User {
    username: string;
    displayname: string;
    token: string;
    image?: string;
  }
  //displayName => displayname
  
  export interface UserFormValues {
    email: string;
    password: string;
    displayname?: string;
    username?: string;
  }