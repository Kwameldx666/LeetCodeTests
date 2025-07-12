# 🧩 LeetCodeTests

<div align="center">

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)
![LeetCode](https://img.shields.io/badge/LeetCode-FFA116?style=for-the-badge&logo=LeetCode&logoColor=black)

*Комплексная коллекция решений задач LeetCode на C#*

[English](#english) | [Русский](#русский)

</div>

---

## 🇺🇸 English

### 📋 Overview

**LeetCodeTests** is a comprehensive collection of LeetCode problem solutions implemented in C# using .NET 8.0. The project is well-organized by algorithmic patterns and data structures, making it an excellent resource for interview preparation and algorithm study.

### ✨ Features

- 🎯 **37+ Problem Solutions** - Wide variety of LeetCode problems
- 📁 **Organized by Patterns** - Solutions categorized by algorithmic techniques
- 🐳 **Docker Support** - Containerized application for easy deployment
- 🔧 **.NET 8.0** - Built with the latest .NET framework
- 📚 **Educational Focus** - Includes data structure implementations
- 🏃‍♂️ **Ready to Run** - Console application with working examples

### 🏗️ Project Structure

```
LeetCodeTests/
├── Task/                          # Core problem solutions
│   ├── Array and String/          # Array and string manipulation
│   │   ├── Candy.cs
│   │   ├── Gas Station.cs
│   │   └── Product of Array Except Self.cs
│   ├── Two Pointers/              # Two-pointer technique
│   │   ├── ValidPalindrome.cs
│   │   ├── 3Sum.cs
│   │   ├── Container With Most Water.cs
│   │   └── Two Sum II - Input Array Is Sorted.cs
│   └── [Other Problems...]
├── Daily Questions/               # Daily LeetCode challenges
├── Sliding Window/               # Sliding window pattern
├── Repeat and learn/             # Data structures & algorithms
│   ├── LinkedList.cs
│   ├── BinarySearchTree.cs
│   ├── Queue.cs
│   └── StackList.cs
└── Dockerfile                    # Container configuration
```

### 🚀 Getting Started

#### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started) (optional)

#### Installation & Running

1. **Clone the repository**
   ```bash
   git clone https://github.com/Kwameldx666/LeetCodeTests.git
   cd LeetCodeTests
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   cd LeetCodeTests
   dotnet run
   ```

#### 🐳 Docker Usage

1. **Build Docker image**
   ```bash
   docker build -t leetcodetests .
   ```

2. **Run container**
   ```bash
   docker run leetcodetests
   ```

### 📚 Problem Categories

#### 🔢 Arrays & Strings
- **Candy Distribution** - Optimal candy allocation algorithm
- **Gas Station** - Circular array traversal
- **Product of Array Except Self** - Array manipulation without division

#### 👥 Two Pointers
- **Valid Palindrome** - String validation with character filtering
- **3Sum** - Finding triplets that sum to zero
- **Container With Most Water** - Area maximization problem

#### 🪟 Sliding Window
- Advanced pattern-based solutions for subarray problems

#### 📊 Data Structures
- Custom implementations of fundamental data structures
- Binary Search Trees, Linked Lists, Queues, Stacks
- Priority Queues and Deques

### 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/new-solution`)
3. Add your solution with proper documentation
4. Commit changes (`git commit -am 'Add solution for Problem XYZ'`)
5. Push to branch (`git push origin feature/new-solution`)
6. Open a Pull Request

### 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

## 🇷🇺 Русский

### 📋 Обзор

**LeetCodeTests** — это комплексная коллекция решений задач LeetCode, реализованных на C# с использованием .NET 8.0. Проект хорошо организован по алгоритмическим шаблонам и структурам данных, что делает его отличным ресурсом для подготовки к собеседованиям и изучения алгоритмов.

### ✨ Особенности

- 🎯 **37+ Решений** - Широкий спектр задач LeetCode
- 📁 **Организация по Шаблонам** - Решения категоризированы по алгоритмическим техникам
- 🐳 **Поддержка Docker** - Контейнеризированное приложение для легкого развертывания
- 🔧 **.NET 8.0** - Построено на новейшем .NET фреймворке
- 📚 **Образовательный Фокус** - Включает реализации структур данных
- 🏃‍♂️ **Готово к Запуску** - Консольное приложение с работающими примерами

### 🚀 Быстрый старт

#### Требования

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started) (опционально)

#### Установка и запуск

1. **Клонируйте репозиторий**
   ```bash
   git clone https://github.com/Kwameldx666/LeetCodeTests.git
   cd LeetCodeTests
   ```

2. **Соберите проект**
   ```bash
   dotnet build
   ```

3. **Запустите приложение**
   ```bash
   cd LeetCodeTests
   dotnet run
   ```

#### 🐳 Использование Docker

1. **Создание Docker образа**
   ```bash
   docker build -t leetcodetests .
   ```

2. **Запуск контейнера**
   ```bash
   docker run leetcodetests
   ```

### 📚 Категории задач

#### 🔢 Массивы и строки
- **Распределение конфет** - Алгоритм оптимального распределения
- **Заправочная станция** - Обход кольцевого массива
- **Произведение массива кроме себя** - Манипуляции с массивом без деления

#### 👥 Два указателя
- **Проверка палиндрома** - Валидация строк с фильтрацией символов
- **Сумма трех** - Поиск троек с нулевой суммой
- **Контейнер с наибольшим количеством воды** - Задача максимизации площади

#### 🪟 Скользящее окно
- Продвинутые решения на основе шаблонов для задач подмассивов

#### 📊 Структуры данных
- Пользовательские реализации фундаментальных структур данных
- Деревья двоичного поиска, связанные списки, очереди, стеки
- Приоритетные очереди и деки

### 🤝 Вклад в проект

1. Форкните репозиторий
2. Создайте ветку функции (`git checkout -b feature/new-solution`)
3. Добавьте ваше решение с соответствующей документацией
4. Зафиксируйте изменения (`git commit -am 'Добавить решение для задачи XYZ'`)
5. Отправьте в ветку (`git push origin feature/new-solution`)
6. Откройте Pull Request

---

<div align="center">

### 🌟 Если проект был полезен, поставьте звездочку!

**Сделано с ❤️ для сообщества разработчиков**

[⬆ Вернуться к началу](#-leetcodetests)

</div>