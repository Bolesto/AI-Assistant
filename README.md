# AI Assistant — Full-Stack Proof of Concept

A proof-of-concept conversational AI assistant exploring a modern
virtual assistant architecture: a React/TypeScript front-end, an
ASP.NET Core Web API and a locally-hosted large language model.

> **Status:** In active development.

## Architecture

React (front-end)  →  ASP.NET Core API (back-end)  →  Ollama (local LLM)

**1. Model** — A large language model (llama3.2) runs locally via Ollama,
exposing a local API at `localhost:11434`. This is the "brain" that
generates responses.

**2. Back end** *(in progress)* — An ASP.NET Core Web API receives a
message from the front-end, forwards it to the model, and returns the
reply. Keeping the model behind the API means it can later be swapped
(e.g. for a cloud service) without changing the front-end.

**3. Front end** *(planned)* — A React + TypeScript chat interface where
the user types messages and sees the assistant's replies.

## Tech Stack

- **Back end:** C#, ASP.NET Core
- **Front end:** React, TypeScript
- **AI model:** Ollama (llama3.2), running locally
- **Tooling:** Git, Visual Studio, VS Code

## Roadmap

- [x] Local model running (Ollama + llama3.2)
- [ ] Back-end Web API with an endpoint that calls the model
- [ ] Front-end chat interface
- [ ] Front-end connected to back-end (full round-trip)
- [ ] Error handling and polish
