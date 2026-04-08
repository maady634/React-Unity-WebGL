# React-Unity-WebGL

# 👟 3D Shoe Configurator (Unity + React + .NET)

An end-to-end **interactive 3D product configurator** built in **4–5 days**, combining **Unity WebGL**, **React (TypeScript)**, and a **.NET 8 backend**.

This project demonstrates real-time customization, full-stack communication, and production-ready architecture.

---

## 🧩 Tech Stack

* 🎮 Unity 2022 LTS + C#
* 🌐 React 18 + TypeScript
* 🔗 React-Unity-WebGL 9.x
* 🧠 .NET 8 Web API
* 💾 EF Core + SQLite

---

## ⚡ Development Timeline (Build Order)

### 🟣 Day 1 — Unity: 3D Model + Material System

* Imported and structured shoe model into modular parts:

  * Sole
  * Upper
  * Laces
* Implemented **per-part color control**
* Used **MaterialPropertyBlock** for performance-friendly updates
* Added **finish system**:

  * Matte (low smoothness)
  * Glossy (high smoothness)

**Key Concepts**

* `_BaseColor`
* `_Smoothness`
* Renderer-level overrides

---

### 🟢 Day 2 — Bridge: React ↔ Unity Communication

* Integrated Unity WebGL build with React using:

  * `react-unity-webgl`
* Implemented messaging system:

  * React → Unity (SendMessage)
  * Unity → React (callbacks/events)

**Result**

* UI actions directly control 3D model in real-time

---

### 🔵 Day 3 — React UI: Configurator Panel

* Built interactive configurator UI:

  * Color pickers
  * Material selectors
  * Variant toggles
* State managed using:

  * `useReducer` (predictable state flow)

**Features**

* Real-time updates synced with Unity
* Clean UX for part-based customization

---

### 🟠 Day 4 — Backend: Save & Load Configurations

* Built REST API using **.NET 8**
* Features:

  * Save configuration
  * Retrieve configuration via ID
* Database:

  * SQLite with EF Core

**Flow**

```id="b5rj7y"
POST /configurations → Save config
GET /configurations/{id} → Load config
```

---

### 🔴 Day 5 — Polish, Optimization & Deployment

* ✨ Smooth transitions (color lerp ~0.3s)
* 🎥 Camera auto-rotation when idle
* ⏳ WebGL loading progress bar in React
* 🚀 Deployment:

  * Frontend + Unity → Vercel
  * Backend → Railway

---

## 🎯 Core Features

### 🎨 Part-Based Customization

* Independent control over each shoe component

### 🧵 Material System

* Swap full materials:

  * Leather
  * Fabric
  * Rubber
  * Carbon Fibre

### 🧱 Variant Switching

* Toggle between mesh variants:

  * High-top / Low-top
  * Sole types

### 💾 Save & Share

* Persist configurations to backend
* Generate shareable IDs
* Reload configurations seamlessly

---

## 🏗️ System Architecture

```id="y08l9j"
React UI (TypeScript)
        ↓
Unity WebGL (C# Runtime)
        ↓
.NET 8 API
        ↓
SQLite Database
```

---

## ⚙️ Setup Instructions

### 1. Clone Repository

```bash id="rklqaz"
git clone https://github.com/your-username/shoe-configurator.git
cd shoe-configurator
```

---

### 2. Unity (WebGL Build)

* Open project in **Unity 2022 LTS**
* Build target: **WebGL**
* Copy build into React public directory

---

### 3. Frontend (React)

```bash id="4e4y8p"
cd frontend
npm install
npm run dev
```

---

### 4. Backend (.NET 8)

```bash id="w8fw8v"
cd backend
dotnet restore
dotnet run
```

---

## 📸 Preview


---

## 🔥 Highlights

* Built in **under 5 days**
* Full-stack integration (Unity + Web + Backend)
* Optimized rendering using **MaterialPropertyBlock**
* Scalable and modular configurator architecture
* Production-ready deployment

---

## 🚀 Future Improvements

* 🛒 Add checkout system
* 📱 Mobile responsiveness
* 🎯 Preset themes (brand-style configs)
* 🌐 Multi-product configurator
* 🤖 AI-based recommendations

---

## 👨‍💻 Author

**Manoj Pranav - Unity Developer**
Creating immersive and scalable interactive systems with Unity & full-stack tech.
