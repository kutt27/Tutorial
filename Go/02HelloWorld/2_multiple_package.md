#### Package Aliases & Multiple packages

We could import multiple packages using the following syntax:

```go
import(
    "package1"
    "package2"
)
```

---
#### Aliases

```go
import(
    p1 "package1"
)
```

In a function we could use this alias instead of the full function name.

#### example
```go
import(
    p1 "fmt"
)

func main(){
	p1.Print("Hello World")
}
```

#### another example with multiple package
```go
package main

import p1 "fmt"
import t "time"

func main() {
	fmt.Println(t.Now())
}
```

Alias can be used also for calling functions. Like;

```go
p1.samplefunc()
```