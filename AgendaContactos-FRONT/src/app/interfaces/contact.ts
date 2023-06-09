export interface Contact {
    id?: number;
    name: string;
    celularNumber: number;
    email: string;
    favorite?: boolean;
}

export interface ContactJsonPlaceholder {
    id: number;
    name: string;
    celularNumber: number;
    email: string;
    favorite?: boolean;
}

export const defaultContact:Contact = {
    id: 12,
    name: "First name",
    celularNumber: 123,
    email: "adasd",
    favorite: true
}
