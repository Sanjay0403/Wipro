interface Contact {
    id: number;
    name: string;
    email: string;
    phone: string;
  }
  
  class ContactManager {
    private contacts: Contact[] = [];
    private nextId: number = 1;
  
    addContact(contact: Contact): void {
      contact.id = this.nextId++;
      this.contacts.push(contact);
      console.log(`Contact added successfully: ${contact.name}`);
    }
  
    viewContacts(): Contact[] {
      if (this.contacts.length === 0) {
        console.log('No contacts available.');
        return [];
      }
      return this.contacts;
    }

    modifyContact(id: number, updatedContact: Partial<Contact>): void {
      const contact = this.contacts.find(c => c.id === id);
      if (contact) {
        Object.assign(contact, updatedContact);
        console.log(`Contact with id ${id} modified successfully.`);
      } else {
        console.log(`Error: Contact with id ${id} not found.`);
      }
    }
  
    deleteContact(id: number): void {
      const index = this.contacts.findIndex(c => c.id === id);
      if (index !== -1) {
        this.contacts.splice(index, 1);
        console.log(`Contact with id ${id} deleted successfully.`);
      } else {
        console.log(`Error: Contact with id ${id} not found.`);
      }
    }
  }
  
  const manager = new ContactManager();
  
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
  