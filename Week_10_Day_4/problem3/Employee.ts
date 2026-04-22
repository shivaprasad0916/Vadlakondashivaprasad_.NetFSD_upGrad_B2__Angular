class Employee {
    public id: number;
    protected name: string;
    private salary: number;

    constructor(id: number, name: string, salary: number) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    public getSalary(): number {
        return this.salary;
    }
    public setSalary(value: number): void {
        if (value > 0) {
            this.salary = value;
        } else {
            console.log("Salary must be greater than 0");
        }
    }

    public displayDetails(): void {
        console.log(`Employee ID: ${this.id} \tName: ${this.name} \tSalary: ${this.salary}`);
    }
}

class Manager extends Employee {
    public teamSize: number;

    constructor(id: number, name: string, salary: number, teamSize: number) {
        super(id, name, salary); 
        this.teamSize = teamSize;
    }


    public displayDetails(): void {
        super.displayDetails(); 
        console.log(`Team Size: ${this.teamSize}`);
    }
}

const emp1 = new Employee(1, "shiva", 30000);
const mgr1 = new Manager(2, "charan", 50000, 5);
emp1.displayDetails();
console.log("Updated Salary: ", emp1.getSalary());
emp1.setSalary(35000);
console.log("After Update: ", emp1.getSalary());

mgr1.displayDetails();