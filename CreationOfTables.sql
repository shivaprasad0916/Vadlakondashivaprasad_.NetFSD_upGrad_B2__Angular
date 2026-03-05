CREATE database EventDb

use EventDb

--USERINFO TABLE--
CREATE table UserInfo
(
	EmailId varchar primary key,
	UserName varchar(50) not null,
	Role varchar(20) not null CHECK(Role IN ('Admin','participant')),
	Password varchar(20) not null CHECK(LEN(Password) >= 6)
);

--EVENTDETAILS--
CREATE table EventDetails
(
	EventId int primary key,
	EventName varchar(50) not null,
	EventCategory varchar(50) not null,
	EventDate datetime not null,
	Description varchar(255),
	status varchar(20) not null CHECK(status IN ('Active','In-Active'))
);

--SPEAKERDETAILS--
CREATE table SpeakerDetails
(
	SpeakerId int primary key ,
	SpeakerName varchar(50) not null,
);

--SESSIONINFO--
CREATE table SessionInfo
(
	sessionId int primary key,
	EventId int not null,
	sessionTitle varchar(50) not null,
	speakerId int not null,
	description varchar(255),
	sessionStart datetime not null,
	sessionEnd datetime not null,
	sessionUrl varchar,
	FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
	FOREIGN KEY (SpeakerId) REFERENCES SpeakerDetails(SpeakerId)
);

--PARTICIPANTINFO--

CREATE table ParticipantInfo
(
	Id int primary key,
	participantEmailId varchar not null,
	EventId int not null,
	sessionId int not null,
	isAttended bit CHECK(isAttended IN ('yes','no')),
	FOREIGN KEY (participantEmailId) REFERENCES UserInfo(EmailId),
	FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
	FOREIGN KEY (sessionId) REFERENCES SessionInfo(SessionId)
);