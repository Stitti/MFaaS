# MFaaS
**Modern Family as a Service**
This is an api with which you can get quotes from modern family. You can filter by the actor or the content of the quote. Or you can just get random quotes
![](modern-family-header.gif)

## API
### `GET /api/quotes`
Returns all quotes.
```json
[
  {
    "quote": "if it were easy, everyone would be hot.",
    "actor": "Haley Dunphy"
  },
  {
    "quote": "The minute they got rid of rotary phones, everything went to hell.",
    "actor": "Jay Pritchett"
  }
]
```

### `GET /api/quotes/random`
Returns a random quote.
```json
{
  "quote": "With great hotness comes great responsibility",
  "actor": "Haley Dunphy"
}
```

### `GET /api/quotes/random/{count}`
Returns an array with `{count}` quotes e.g. `GET /v1/quotes/random/3`.
```json
[
  {
    "quote": "I'm cool dad, that's my thang. I'm hip, I surf the web, I text. LOL: laugh out loud, OMG: oh my god, WTF: why the face.",
    "actor": "Phil Dunphy"
  },
  {
    "quote": "Comfort is not everything. My toes have been numb since my Quinceanera.",
    "actor": "Gloria Delgado-Pritchett"
  },
  {
    "quote": "Manny thinks his dad is like Superman. The truth? He's a total flake. In fact, the only way he's like Superman... is that they both landed in this country illegally.",
    "actor": "Jay Pritchett"
  }
]
```

### `GET /api/quotes/actor/{actor}`
Returns a list of all quotes of actors whose name contains the value of `{actor}` e.g. `GET /v1/quotes/actor/dunphy`.
```json
[
  {
      "quote": "uccess is 1% inspiration, 98% perspiration, and 2% attention to detail.",
      "actor": "Phil Dunphy"
    },
    {
      "quote": "if it were easy, everyone would be hot.",
      "actor": "Haley Dunphy"
    },
    {
      "quote": "When life gives you lemonade, make lemons. Life will be all, Whaaat?",
      "actor": "Phil Dunphy"
    },
    {
      "quote": "I've been thinking of moving out for some time now. There's a line of ants going to a trick-or-treat bag in my closet, and I don't want to still be here when     they get sick of candy.",
      "actor": "Luke Dunphy"
    }
  ]
```

### `GET /api/quotes/actor/{actor}`
Returns a list of all quotes that contain the value of `{query}` e.g. `GET /v1/quotes/query/tongue`.
```json
[
  {
    "quote": "What could be more natural than your mother's tongue in your ear?",
    "actor": "Gloria Delgado-Pritchett"
  }
]
```

## Contributing
If you want to contribute, add a quote and the actor in `quote.json`
