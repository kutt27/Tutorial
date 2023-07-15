#### Structure of the main.go file

Here we first declaring a package called 'main'

```go
package main
```

Importing a package already in go module called 'fmt'. It includes basic I/O operation.

```go
import "fmt"
```

This is how we declare a function in 'go' and using the package 'fmt' to print the word hello world.

```go
func main(){
	fmt.Print("Hello World")
}
```