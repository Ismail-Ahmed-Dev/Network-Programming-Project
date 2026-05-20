# Multi-threaded File Compression System

A simple Client-Server application built using C# that allows clients to send files to a server, compress them, and receive the compressed version back.

---

# 📌 Project Overview

This project consists of two main parts:

## 🖥️ Compression Server
A multi-threaded TCP server that:
- Accepts multiple clients simultaneously
- Receives files from clients
- Compresses files using GZip
- Sends compressed files back

---

## 💻 Client Application
A Windows Forms application that allows users to:
- Select files
- Send files to the server
- Receive compressed files
- Save compressed files automatically

---

# 🛠️ Technologies Used

- C#
- .NET Framework
- Windows Forms
- TCP Sockets
- Multithreading
- GZip Compression

---

# 📂 Project Structure

Project/
│
├── Server/
│   ├── Program.cs
│   └── ...
│
├── Client/
│   ├── Form1.cs
│   └── ...
│
└── README.md


## ⚙️ How It Works

### 1️⃣ Start the Server
Run the server application to initialize the backend services.
<img width="1102" height="635" alt="Annotation 2026-05-21 001355" src="https://github.com/user-attachments/assets/0264c875-c220-4f7c-b715-44c44527098b" />

### 2️⃣ Open the Client
Run the Windows Forms client application to connect to the running server.
<img width="832" height="535" alt="image" src="https://github.com/user-attachments/assets/ab93c038-713c-4acb-90ea-b6109d3e183a" />

### 3️⃣ Select a File
Click the **Select File** button within the client interface and choose any file you wish to process or send.

**File Selection:**
* Opens a standard Windows `OpenFileDialog`.
* Supports any file format (e.g., `.txt`, `.png`, `.pdf`).

<img width="1100" height="840" alt="Annotation 2026-05-21 002454" src="https://github.com/user-attachments/assets/dfb1d5e6-f1bc-4b99-8fb0-bfbba79cc2a4" />

### 4️⃣ Send the File
Click the **Send** button to transmit the selected file to the server. 

**What happens under the hood:**
* 📊 **Sends the file size:** The client first transmits the exact size of the file so the server knows how many bytes to expect.
* 📦 **Sends the file data:** The client streams the actual file data across the network socket.

<img width="812" height="502" alt="Annotation 2026-05-21 002726" src="https://github.com/user-attachments/assets/f5ff0a8b-087b-4548-aadd-2ee2df2a5402" />


Server Processing & Response
Once the data is transmitted, the server handles the incoming stream and responds:

* 📥 **Receives the file:** The server accepts the incoming byte stream based on the previously received file size.
* 🗜️ **Compresses it:** The server applies a compression algorithm to reduce the file size efficiently.
* ↩️ **Sends it back:** The compressed file is streamed back to the client application.

<img width="1112" height="642" alt="Annotation 2026-05-21 003322" src="https://github.com/user-attachments/assets/45ad17d9-2390-4c2b-b0e0-6f3ef17220c1" />


### 5️⃣ Receive the Compressed File
The client application handles the incoming compressed data stream from the server.

**Final Output:**
* 💾 **Automatic Saving:** The compressed version of the file is automatically processed and saved to the designated output directory.
* 📈 **Efficiency:** You will find the newly created file reduced in size, ready for use.


<img width="792" height="485" alt="Annotation 2026-05-21 003712" src="https://github.com/user-attachments/assets/72a9fe12-1426-40cb-9918-f8c420e5aaac" />

<img width="796" height="473" alt="Annotation 2026-05-21 003757" src="https://github.com/user-attachments/assets/ce8da7d0-821a-4a4d-b5e8-7c20fdf39d73" />

<img width="1427" height="726" alt="Annotation 2026-05-21 004037" src="https://github.com/user-attachments/assets/256b290b-4b89-45ca-ae66-6ac527eb2972" />


## 🚀 Features

* 🧵 **Multi-Threaded Server:** Capable of handling multiple client connections simultaneously without blocking the main execution thread.
* 👥 **Multiple Client Handling:** Designed to scale and manage concurrent data streams from various clients at the same time.
* ⚡ **TCP Communication:** Safe and reliable data transmission built on top of robust TCP network sockets.
* 🗜️ **File Compression:** Optimized server-side logic that automatically compresses received files to save bandwidth and storage.
* 💾 **Automatic File Saving:** Seamless client-side integration that automatically writes the returned compressed file to disk.
* 🖥️ **Windows Forms UI:** A clean, intuitive, and user-friendly desktop interface for the client application.

## 🔮 Future Improvements

Here are some features and enhancements planned for future updates:

- [ ] **🔓 Add Decompression Support:** Implement server/client logic to extract and decompress files back to their original state.
- [ ] **⏳ Add Progress Bar:** Visual indicator in the UI to track real-time file upload, compression, and download progress.
- [ ] **🎨 Improve UI Design:** Modernize the Windows Forms interface with a cleaner layout and enhanced user experience.
- [ ] **🖱️ Add Drag & Drop:** Allow users to simply drag files directly into the client window for faster selection.
- [ ] **📦 Support Large File Transfer:** Optimize buffer streaming to handle massive files without consuming excessive memory.
- [ ] **🔒 Add Encryption:** Secure data transmission by encrypting files before sending them over TCP sockets.

---

## ▶️ How to Run

Follow these quick steps to get the project up and running locally.

### 🖥️ Server
1. Open the **Server project** in your IDE (e.g., Visual Studio / VS Code).
2. Run the application to start listening on port `5000`.

### 💻 Client
1. Open the **Client project** in a separate instance or terminal.
2. Run the application to launch the Windows Forms UI.
3. Click the **Select file** button and choose your target file.
4. Click **Send** to process the file through the server.

---
## 👨‍💻 Author

Built with 💻 and ☕ by **Ismail Ahmed** [![GitHub](https://img.shields.io/badge/GitHub-Profile-181717?style=for-the-badge&logo=github)](https://github.com/YOUR_GITHUB_USERNAME)
