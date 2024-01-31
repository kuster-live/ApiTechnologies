---
theme: uncover
paginate: true
backgroundColor: #fff
marp: true
backgroundImage: url('bg.jpg')
class:
  - invert
---
<!-- invert -->
# dotnet APi technologies

## Grpc, Rest and GraphQL

---
## About me

### Raphael Kuster

Software Dev for ~10y
a lot of random other stuff (festivals, woodworking ...)


<br/><br/>

![xlogo.svg w:32](https://upload.wikimedia.org/wikipedia/commons/c/ce/X_logo_2023.svg) **@rfKust**     ![ghlogo.svg w:32](https://upload.wikimedia.org/wikipedia/commons/9/91/Octicons-mark-github.svg) **BigHoss**<!-- fit -->



---


## Rest

### Benefits

- Technology agnostic (it's just text)
- Human readable
- Easy doc (Swagger)
- widely used
- Caching
<!-- _footer: "Rest" -->

---

<!-- _footer: "Rest" -->

### Drawbacks

- Lots of boilerplate (code & content)
- Performance
- Over- / Underfetching
- No Realtime functionality out of the box
- Complexity with Hierarchical Data

---

# Rest Demo

---

## GraphQL

### Benefits

- Data Fetching Efficiency
- Strong Typing
- Automatic Documentation
- Performant Subscriptions

<!-- _footer: "GraphQl" -->
---

### Drawbacks

- Complexity
- Performance for large Queries
- Caching complexity 
- Complicated Versioning

<!-- _footer: "GraphQl" -->


---

# GraphQL Demo

---

## Grpc

[grpc.io](grpc.io)

### Benefits

- Performance
- Language-Independent
- Bi-Directional Streaming and flow control
- Deadlines and Cancellation Propagation
- Strongly-Typed Service Contracts

<!-- _footer: "Grpc" -->

<!-- supported languages:
C# / .NET
C++
Dart
Go
Java
Kotlin
Node
Objective-C
PHP
Python
Ruby -->

---

### Drawbacks

- Limited Browser Support (except grpc-web)
- Less Human Readable
- Another language to describe contracts


<!-- _footer: "Grpc" -->

---

# Grpc Demo

---


## Thanks for your attention

The code is on github

[https://github.com/kuster-live/ApiTechnologies](https://github.com/kuster-live/ApiTechnologies)

![qrcode w:250](qr-code.png)


<!-- _footer: "Backgroundimage by coolvector on Freepik" -->
<!-- link to background image https://www.freepik.com/free-vector/gradient-hexagonal-background_13955213.htm#query=svg%20background&position=3&from_view=keyword&track=ais&uuid=cd1420f3-a9b1-466b-80cd-7712f43308a7 -->
