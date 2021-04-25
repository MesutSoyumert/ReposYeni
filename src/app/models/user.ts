export interface User{
    userId:number;
    userFirstName:string;
    userLastName:string;
    userEmail:string;
    userPasswordHash:string;
    userPasswordSalt:string;
    userStatus:boolean;
}