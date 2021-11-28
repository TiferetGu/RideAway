export class Passenger {
    ID: number
    IdentityNumber: number
    RavKavId: string
    ValidationDate: Date
    ReasonOfDelayId: number
    SourceStationId: number
    DestinationStationId: number
    DestinationRouteId: number


    constructor(ID, IdentityNumber, RavKavId, ValidationDate, ReasonOfDelayId, SourceStationId, DestinationStationId, DestinationRouteId) {
        this.ID = ID;
        this.IdentityNumber = IdentityNumber;
        this.RavKavId = RavKavId;
        this.ValidationDate = ValidationDate;
        this.ReasonOfDelayId = ReasonOfDelayId;
        this.SourceStationId = SourceStationId;
        this.DestinationStationId = DestinationStationId;
        this.DestinationRouteId = DestinationRouteId;
        }
    }