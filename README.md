# 💊 HealthFirst Pharmacy Management System

### Business Analysis | C#/.NET | Database Design | Process Improvement

HealthFirst Pharmacy Management System is a database-driven Windows Forms application designed to support core pharmacy operations through a centralized system.

The project translates pharmacy business requirements into a functional C#/.NET application supporting role-based workflows for customers, pharmacists, sales managers, and administrators.

---

## 🎯 Business Problem

Pharmacy operations involve interconnected processes across prescriptions, medication inventory, customer records, employees, sales, and deliveries.

Managing these activities through fragmented or manual processes can lead to:

- Limited visibility into medication inventory
- Inefficient prescription processing
- Difficulty maintaining customer and operational information
- Increased risk of manual errors
- Limited coordination between operational roles

The goal of **HealthFirst Pharmacy** was to design a centralized system that connects these workflows and improves information accessibility and operational efficiency.

---

## 💡 Solution

HealthFirst was designed as a role-based pharmacy management application that combines a structured database with C#/.NET Windows Forms interfaces.

The system supports:

- 💊 Prescription and medication management
- 📦 Inventory and stock management
- 👥 Customer information management
- 👨‍⚕️ Pharmacist workflows
- 📊 Sales management
- 🚚 Delivery-related operations
- 🔐 Role-based login and access
- 🗄️ Centralized operational data

---

## 👥 Role-Based Application Modules

### Customer
Supports customer-facing pharmacy activities including account access, prescription submission, and medication information.

### Pharmacist
Supports prescription processing and pharmacy-related operational workflows.

### Sales Manager
Supports medication inventory operations, including adding, updating, and removing inventory records and identifying expired medications.

### Administrator
Provides administrative functionality for managing system-level operational information.

---

## 🔄 Business Analysis Approach

**1. Identified the Business Problem**  
Analyzed operational challenges across prescriptions, inventory, customers, employees, sales, and pharmacy workflows.

**2. Defined Business Requirements**  
Translated operational needs into system requirements, business rules, application functions, and data requirements.

**3. Designed the Data Model**  
Defined entities, attributes, primary keys, foreign keys, and relationships required to support pharmacy operations.

**4. Developed the Application**  
Implemented role-based application modules using C# and .NET Windows Forms.

**5. Connected Application & Data Requirements**  
Designed application workflows around structured pharmacy data and relational database concepts.

---

## 🏗️ System Architecture

The project follows a database-driven desktop application structure:

**User → Role-Based Windows Forms Interface → Application Logic → Pharmacy Data**

Primary application roles:

`Customer` → `Pharmacist` → `Sales Manager` → `Administrator`

The source code includes separate Windows Forms modules and supporting resource files for these application functions.

---

## 🛠️ Tools & Technologies

**Programming:** C#  
**Framework:** .NET Framework / Windows Forms  
**Database & Querying:** Microsoft Access, SQL  
**Database Design:** ERD, Relational Data Modeling, Primary & Foreign Keys  
**Business Analysis:** Requirements Analysis, Business Rules, Process Analysis, Data Requirements  
**Development Environment:** Visual Studio

---

## 📊 Project Impact

The project demonstrates how business requirements can be translated into a structured information system connecting pharmacy operations, application workflows, and data management.

Key outcomes demonstrated through the project include:

- Centralized pharmacy information across multiple operational functions
- Role-based application workflows
- Structured medication and inventory management
- Prescription-processing support
- Translation of business requirements into application functionality
- Integration of business analysis, database design, and software development concepts

---

## 📁 Repository Structure

```text
healthfirst-pharmacy-management-system/
│
├── diagrams/
│   └── Database and system design documentation
│
├── src/
│   ├── Properties/
│   ├── Customer.cs
│   ├── Customer.Designer.cs
│   ├── Login.cs
│   ├── Login.Designer.cs
│   ├── Pharmacist.cs
│   ├── Pharmacist.Designer.cs
│   ├── SalesM.cs
│   ├── SalesM.Designer.cs
│   ├── Signup.cs
│   ├── Signup.Designer.cs
│   ├── admin.cs
│   ├── admin.Designer.cs
│   ├── Program.cs
│   ├── App.config
│   └── HealthFirst.csproj
│
└── README.md
