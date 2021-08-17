create table "Orders" (
    "Id" serial primary key,
    "SourceCity" varchar(100),
    "SourceAddress" varchar(100),
    "DestinationCity" varchar(100),
    "DestinationAddress" varchar(100),
    "Weight" numeric,
    "PickUpDate" date
)