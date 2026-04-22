"use strict";
function getWelcomeMessage(name) {
    return `Hello ${name} Welcome.`;
}
function getUserInfo(name, age) {
    if (age != undefined) {
        return `User ${name} is ${age} old.`;
    }
    else {
        return `User is${name} and age is not provided.`;
    }
}
function getSubscriptionStatus(name, isSubscribed = false) {
    if (isSubscribed == false) {
        return `User ${name} is Subscribed Successfully.`;
    }
    else {
        return `User ${name} is Not Subscribed.`;
    }
}
function isEligibleForPremiumn(age) {
    return age > 18;
}
const getAccountStatus = (name) => {
    return `Account of ${name} is active.`;
};
const NotificationService = {
    appName: "MyApp",
    sendNotification: (user) => {
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
