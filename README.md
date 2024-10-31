# Building an integration between the norwegian accounting software Tripletex and a generic webstore

### This project was started on October 30th 2024

## The general flow

In norway, businesses are obliged to report on all sales on a webstore as if they are invoice sales. **First**, the customer must be registered as a contact in the accounting software, if their information isn’t already there which is:

1. **Name**,
2. **Address**,
3. **Phone number**
4. **Email** (*not an absolute must but preferred)

**Then** they need all the information of the order such as:

1. **Date of invoice** (Basically the date of order on the webstore)
2. **Customer info** (after they have been registered as a contact)
3. **Each product AS ORDER LINE ITEM that has been ordered** which could include shipping
    1. The product should include the **proper norwegian tax account** for example: “3000 salgsinntekt handelvarer, avgiftspliktig”
    2. **Gross** (before tax)
    3. **Tax percentage** (default 25%)
    4. **Net** (after tax)
4. Payment from service (Stripe cuz it can do a CSV export)
    1. Export from Stripe for month
    2. Import to Bookkeeping for month
        1. Specify bank account that stripe is sending to.

The customer number from the online store does not need to follow the same sequence as in Tripletex, as long as it does not conflict with existing customer numbers in Tripletex. It is important to ensure that customer numbers do not collide with those already registered, either manually or through other integrations. If I receive an error message indicating that the customer number is already in use, there may also be a conflict with the supplier number, since customers and suppliers share number series in Tripletex.

## Assumptions I’m making for simplicity and MVP:

- The webstore has a very smooth and understandable REST API
- It provides the exact same data we need to add to Tripletex
    - This is because I can add more validation requirements in the future
- We have already collected the data from said API
- We are NOT connecting the products to the orderline. We are ONLY inputting the orderline info directly into a POST invoice request in Tripletex.
- Payment service with CSV export

## Disse tjukke er obligatoriske for tripletex. Resten er kun for mitt tilfelle

1. **Fakturanummer** (INVOICE NO): Fakturanummeret som brukes til å identifisere fakturaen.
2. **Fakturadato** (INVOICE DATE): Datoen fakturaen er utstedt. Format: YYYY-MM-DD.
3. **Forfallsdato** (DUE DATE): Datoen fakturaen skal betales. Format: YYYY-MM-DD.
4. **Ordrenummer** (ORDER NO): Ordrenummer knyttet til fakturaen.
5. **Kundenummer** (CUSTOMER NO): Nummeret som identifiserer kunden i systemet.
6. Kundenavn (CUSTOMER NAME): Navnet på kunden som fakturaen gjelder.
7. Kundens e-postadresse (CUSTOMER EMAIL): E-postadresse for å sende faktura til kunden.
8. Organisasjonsnummer (ORGANIZATION NO): Kunden/leverandørens organisasjonsnummer.
9. Valuta (CURRENCY): Valutaen som brukes i fakturaen, for eksempel NOK, SEK, DKK.
10. **Ordredetaljer** - Beskrivelse (ORDER LINE - DESCRIPTION): Beskrivelse av hvert produkt eller tjeneste på fakturaen.
11. **Ordredetaljer** - Enhetspris (ORDER LINE - UNIT PRICE): Pris per enhet for produktet eller tjenesten.
12. **Ordredetaljer** - Antall (ORDER LINE - COUNT): Antall enheter av produktet eller tjenesten.
13. **Ordredetaljer** - MVA-kode (ORDER LINE - VAT CODE): Norsk kontonummer på produktet.