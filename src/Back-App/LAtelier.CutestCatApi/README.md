# Welcome to LAtelier.CutestCatApi.Api

This is a basic asp.net core project for fetching cats data and vote for the cutests

## Step for building and run app

with docker cli run commands

### `build docker image`

```
docker build -t cutest_cat_api .
```

### `run app`

```
docker run -d -p 7027:80 cutest_cat_api
```

## Launch and test app in browser

`open the swagger of application LAtelier.CutestCatApi.Api`

Open [http://localhost:7027/swagger/index.html](http://localhost:7027/swagger/index.html) to view it in your browser.
