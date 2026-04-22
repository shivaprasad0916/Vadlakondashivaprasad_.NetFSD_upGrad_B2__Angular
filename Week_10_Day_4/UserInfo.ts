const userName:string = "John";              
let age:number= 25;                         
const email:string = "john@example.com";     
const isSubscribed:boolean = true;           

let userAge: number = age;
let userEmail: string = email;

const message:string=`Hello ${userName}, you are ${age} years old and your email is ${email}.`
console.log(message)
age = age + 1;

const isEligibleForPremium: boolean = age > 18 && isSubscribed;

console.log("User Name:", userName);
console.log("Age after increment:", age);
console.log("Email:", email);
console.log("Subscribed:", isSubscribed);

console.log("Message:", message);

console.log("Premium Eligible:", isEligibleForPremium);
