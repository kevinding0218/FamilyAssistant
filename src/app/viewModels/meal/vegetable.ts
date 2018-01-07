export interface KeyValuePairInfo {
    id: number;
    name: string;
}

export interface SaveVegetable {
    keyValuePairInfo: KeyValuePairInfo;
    addedOn: Date;
    addedByUserId: number;
    updatedOn: Date;
    lastUpdatedByUserId: number;
}