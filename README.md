# Introduction to Design Patterns with C# — Source Code

*For further enquiry please contact Akin Kaldiroglu at akin@kaldiroglu.dev*

**Created:** 2026-06-01
**Project:** Companion source code for the course *Introduction to Design Patterns with C#* — the C# port of the Java edition. It backs the slides with runnable examples.

## Expected benefits

- A small, runnable codebase students can read alongside the video.
- The course examples in real, idiomatic C#:
  1. **Three "before" smells** — a nested `if-else-if` access check (`complexIfs`), a factory-heavy object graph (`complexObject`), and telescoping constructors (`db`).
  2. **The Proxy pattern** — the Citizen / Prime Minister exercise, in three refactoring stages (the *after* picture).

## Functional properties

This is a faithful, idiomatic-C# port of the author's Java repo. It covers **all four**
examples from the Java source — two "problem" (before) examples and the Proxy pattern in
three stages.

- **`problems.complexIfs`** — `User` (many fields) + `UserProcessor.ProcessUser`, a deeply nested `if` tree returning access-code strings (e.g. `FULL_ACCESS_GRANTED`). Kept deliberately as the Big Ball of Mud the course teaches you to refactor.
- **`problems.complexObject`** — a `UserService` that assembles a `User` graph from a `NewUserRequest` through several factories (`UserFactory`, `RoleFactory`, `UserCategoryFactory`, `ConfigurationFactory`). The factories are deliberately left as **stubs that return null** — the "complex object construction" smell that motivates the **Factory / Builder** patterns.
- **`problems.db`** — `DatabaseConnection`, a class drowning in **telescoping constructors** plus post-construction setters. The "before" picture that motivates the **Builder** pattern. `Demo.Run()` mirrors the Java `db/Main`'s four connection profiles.
- **`proxy.pm`** — the Gang of Four **Proxy** pattern, in three stages mirroring the Java repo (`pm1`/`pm2`/`pm3`):
  - **pm1 (Solution 1):** `Citizen` → concrete `PM` (low cohesion — the PM sorts out *and* resolves).
  - **pm2 (Solution 2):** `Citizen` → `Proxy` → `PM` (the proxy sorts out and delegates; the citizen still knows it talks to a `Proxy`).
  - **pm3 (Solution 3):** `PM` is an **interface** (the *Subject*); `RealPM` (RealSubject) and `ProxyPM` (Proxy) implement it; `PMSecretary` is a **factory** (`GetMePM()`) serving a `ProxyPM` typed as `PM`; `Citizen` (Client) depends only on `PM`.

> The interface is named **`PM`** (not `IPM`) to match the Java source and the slides.

## Architectural approach

- GoF Proxy pattern; programming **to an interface** (`PM`), favoring composition (`ProxyPM` holds a `RealPM`) — the principles from the course.
- Idiomatic C#: PascalCase members, `string`/`bool`, file-scoped namespaces, nullable reference types enabled.
- Namespaces mirror the Java packages under root **`dev.kaldiroglu.dp.intro`** (`.problems.complexIfs`, `.problems.complexObject[.user]`, `.problems.db`, `.proxy.pm.pm1/pm2/pm3`).
- Java JavaBeans (private fields + getters/setters) become C# **auto-properties**; boxed `Long` becomes `long?`. Deliberately-incomplete stubs in the Java source are preserved as stubs, not "fixed".
- The three `pm` stages each have a `Demo.Run()` that mirrors the corresponding Java `Main`.

## Layout

```
IntroductionToDesignPatternsWithCSharp/
├── src/
│   ├── IntroductionToDesignPatterns.csproj      (net9.0, console app)
│   ├── Program.cs                               (runs the pm1/pm2/pm3 + db demos)
│   ├── problems/
│   │   ├── complexIfs/    { User.cs, UserProcessor.cs }
│   │   ├── complexObject/ { NewUserRequest.cs, UserService.cs,
│   │   │                    user/ { User.cs, Role.cs, Category.cs, Configuration.cs,
│   │   │                            Privilege.cs, RolePrivilege.cs, UserRole.cs,
│   │   │                            UserCategory.cs, UserFactory.cs, RoleFactory.cs,
│   │   │                            UserCategoryFactory.cs, ConfigurationFactory.cs } }
│   │   └── db/            { DatabaseConnection.cs, Demo.cs }
│   └── proxy/pm/
│       ├── pm1/ { PM.cs, Citizen.cs, Demo.cs }
│       ├── pm2/ { PM.cs, Proxy.cs, Citizen.cs, Demo.cs }
│       └── pm3/ { PM.cs, RealPM.cs, ProxyPM.cs, PMSecretary.cs, Citizen.cs, Demo.cs }
```

> The `complexObject` example has no `Main` in the Java repo, so (like the original) it is compile-only — it demonstrates structure rather than running output.

This is a read-along companion to the course: there is no test project (the Java original has none either). The behaviour is shown by running the demos.

## Run it with

```sh
# from the repo root

# run the demos
dotnet run --project src
```
