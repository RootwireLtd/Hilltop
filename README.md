# Hilltop
Oversee your kingdom from Hilltop

This project's goal is to provide a series of API endpoints for receiving POST requests from other tools related to CyberEssentials assessment criteria. The project is expected to expand to fit other needs of your business and provide an aggregation point for a high-level overview of the health of your business.

Visualisation and reporting on the data are outside of the scope of the projects primary codebase at this time, and are instead provided by 3rd party open source solutions such as Grafana.

Outside of the API codebase, the following types of files are also in scope of the project repository, but only for ancilliary and exemplary purposes. This list is non-exhaustive, and we are very open to ideas, discussions, and contributions.

- Grafana Dashboards
- Docker Compose Files
- Helm Charts

# Contributing

# Run the Dev Server

## Configure Git

1. Configure git to ignore the Prettier version

```bash
git config blame.ignoreRevsFile .git-blame-ignore-revs
```

2. Set up the pre-commit `dotnet format` hook

```bash
git config --local core.hooksPath .git-hooks
```

## Configure Docker

1. Some settings are configured in the environment file at `dev/.env`. Copy the example env file.

```bash
cd dev
cp .env.example .env
```

2. Open `.env` and set the variables to your preference.

3. Optionally, configure the reverse proxy by copying `/dev/reverse-proxy.conf.example` to `dev/reverse-proxy.conf` and editing the file to suit your needs.

## Run docker

1. Start the docker containers

Navigate in to the `dev` folder and run the docker command line below

```bash
docker compose --profile stack up -d
```

## Setting user secrets

1. Copy the template secrets.json

```bash
cp secrets.json.example secrets.json
```

2. Update secets.json with your own settings and configuration requirements.

3. Run the below helper script to add all the secrets to each Hilltop server project.

```pwsh
pwsh setup_secrets.ps1
```

The script also supports an optional `-clear` option to remove existing settings before reapplying them.

```pwsh
pwsh setup_secrets -clear
```

## Build and Run the server

You are now ready to run the server.

1. Open a terminal window at the root of the project.
2. Start the API

```bash
cd src/API
dotnet restore
dotnet run
```

3. Test that the API is alive by navigating to http://localhost:5248/alive

