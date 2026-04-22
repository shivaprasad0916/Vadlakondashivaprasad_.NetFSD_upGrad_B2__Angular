function getWelcomeMessage(name: string): string{
    return `Hello ${name} Welcome.`
}

function getUserInfo(name: string, age?: number): string{
    if(age != undefined){
        return `User ${name} is ${age} old.`
    }
    else{
        return`User is ${name} and age is not provided.`
    }
}

function getSubscriptionStatus(name: string, isSubscribed: boolean = false): string{
    if(isSubscribed == false){
        return `User ${name} is Subscribed Successfully.`
    }
    else{
        return`User ${name} is Not Subscribed.`
    }
}

function isEligibleForPremiumn(age: number): boolean {
    return age > 18;
}

const getAccountStatus = (name: string): string => {
    return `Account of ${name} is active.`;
};

const NotificationService = {
    appName: "MyApp",

    sendNotification: (user: string): string => {
        return `Hello ${user}, welcome to ${NotificationService.appName}`;
    }
};

console.log(getWelcomeMessage("shiva prasad"));

console.log(getUserInfo("shiva prasad", 23));
console.log(getUserInfo("shiva prasad"));

console.log(getSubscriptionStatus("shiva prasad", true));
console.log(getSubscriptionStatus("shiva prasad"));

console.log("Eligible for Premium:", isEligibleForPremiumn(23));

console.log(getAccountStatus("shiva prasad"));

console.log(NotificationService.sendNotification("shiva prasad"));
