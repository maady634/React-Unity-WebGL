# React-Unity-WebGL

<img width="1919" height="1079" alt="Screenshot 2026-04-09 091509" src="https://github.com/user-attachments/assets/0fb2d2f1-95e4-47a8-a5c0-ff95f62cacb8" />
## Live Demo

https://sneaker-configurator-tau.vercel.app/

# 3D Shoe Configurator (Unity + React + .NET)

An end-to-end interactive 3D product configurator built in 4–5 days using Unity WebGL, React (TypeScript), and a .NET 8 backend.

This project demonstrates real-time customization, full-stack communication, and a scalable architecture.

---

## Tech Stack

* Unity 2022 LTS + C#
* React 18 + TypeScript
* React-Unity-WebGL 9.x
* .NET 8 Web API
* Entity Framework Core + SQLite

---

## Development Timeline (Build Order)

### Day 1 — Unity: 3D Model + Material System

* Structured the shoe into modular parts:

  * Sole
  * Upper
  * Laces
* Implemented per-part color customization
* Used MaterialPropertyBlock for efficient rendering updates
* Added finish options:

  * Matte (low smoothness)
  * Glossy (high smoothness)

Key Concepts:

* `_BaseColor`
* `_Smoothness`
* Renderer-level overrides

---

### Day 2 — Bridge: React ↔ Unity Communication

* Integrated Unity WebGL with React using react-unity-webgl
* Implemented bidirectional communication:

  * React → Unity (SendMessage)
  * Unity → React (callbacks/events)

Result:

* UI controls update the 3D model in real-time

---

### Day 3 — React UI: Configurator Panel

* Built a configurable UI:

  * Color pickers
  * Material selectors
  * Variant toggles
* Managed state using useReducer

Features:

* Real-time synchronization with Unity
* Clean and modular UI structure

---

### Day 4 — Backend: Save & Load Configurations

* Developed REST API using .NET 8
* Features:

  * Save configuration
  * Retrieve configuration via ID
* Database:

  * SQLite with EF Core

API Endpoints:

```
POST /configurations
GET /configurations/{id}
```

---

### Day 5 — Polish, Optimization & Deployment

* Smooth transitions (color interpolation ~0.3s)
* Camera auto-rotation when idle
* WebGL loading progress integration in React

Deployment:

* Frontend + Unity WebGL → Vercel
* Backend → Railway

---

## Core Features

### Part-Based Customization

* Independent control of each shoe component

### Material System

* Swap full materials:

  * Leather
  * Fabric
  * Rubber
  * Carbon Fibre

### Variant Switching

* Toggle between mesh variants:

  * High-top / Low-top
  * Sole variations

### Live Pricing System

* Dynamic pricing based on selected options
* Real-time configuration summary

### Save & Load

* Persist configurations via backend
* Generate shareable IDs
* Restore configurations seamlessly

---

## Architecture

```
React UI (TypeScript)
        ↓
Unity WebGL (C#)
        ↓
.NET 8 API
        ↓
SQLite Database
```

---

## Setup Instructions

### 1. Clone Repository

```bash
git clone https://github.com/your-username/shoe-configurator.git
cd shoe-configurator
```

---

### 2. Unity (WebGL Build)

* Open in Unity 2022 LTS
* Switch platform to WebGL
* Build and place output in React public folder

---

### 3. Frontend (React)

```bash
cd frontend
npm install
npm run dev
```

---

### 4. Backend (.NET 8)

```bash
cd backend
dotnet restore
dotnet run
```

---

## Preview

Add screenshots or GIFs here to demonstrate:

* Color customization
* Material switching
* Variant toggling
* UI interaction

---

## Highlights

* Built within 4–5 days
* Full-stack integration (Unity + Web + Backend)
* Efficient rendering using MaterialPropertyBlock
* Modular and scalable configurator design
* Ready for deployment

---

## Future Improvements

* Add cart and checkout system
* Mobile optimization
* Preset themes
* Multi-product configurator support
* AI-based recommendations

---

## Author

Manoj Pranav, Unity Developer
Focused on building interactive and scalable systems with Unity and modern web technologies.
