var ContactManager = /** @class */ (function () {
    function ContactManager() {
        this.contacts = [];
        this.nextId = 1;
    }
    ContactManager.prototype.addContact = function (contact) {
        contact.id = this.nextId++;
        this.contacts.push(contact);
        console.log("Contact added successfully: ".concat(contact.name));
    };
    ContactManager.prototype.viewContacts = function () {
        if (this.contacts.length === 0) {
            console.log('No contacts available.');
            return [];
        }
        return this.contacts;
    };
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var contact = this.contacts.find(function (c) { return c.id === id; });
        if (contact) {
            Object.assign(contact, updatedContact);
            console.log("Contact with id ".concat(id, " modified successfully."));
        }
        else {
            console.log("Error: Contact with id ".concat(id, " not found."));
        }
    };
    ContactManager.prototype.deleteContact = function (id) {
        var index = this.contacts.findIndex(function (c) { return c.id === id; });
        if (index !== -1) {
            this.contacts.splice(index, 1);
            console.log("Contact with id ".concat(id, " deleted successfully."));
        }
        else {
            console.log("Error: Contact with id ".concat(id, " not found."));
        }
    };
    return ContactManager;
}());
var manager = new ContactManager();
manager.addContact({ id: 0, name: 'Sanjay Kumar', email: 'sanjay.kumar@example.com', phone: '555-123-4567' });
manager.addContact({ id: 0, name: 'Deep Patel', email: 'deep.patel@example.com', phone: '555-234-5678' });
manager.addContact({ id: 0, name: 'Raj Verma', email: 'raj.verma@example.com', phone: '555-345-6789' });
console.log(manager.viewContacts());
manager.modifyContact(1, { name: 'Sanjay Singh', phone: '555-678-9012' });
console.log(manager.viewContacts());
manager.deleteContact(2);
console.log(manager.viewContacts());
manager.modifyContact(99, { name: 'Nonexistent Contact' });
manager.deleteContact(99);
