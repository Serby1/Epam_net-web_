class Service {

    constructor() {
        this.collection = new Map();
        this.idSetter = 0;
    }


    add(obj) {

        if (!obj || typeof (obj) != 'object') {

            console.log("The argument must be an object!");
            return;
        }

        ++this.idSetter;
        this.collection.set(this.idSetter.toString(), obj);

        return this.idSetter.toString();

    }

    getById(id) {

        if (id && this.collection.has(id)) {
            return this.collection.get(id);
        }
        
        return null;
    }

    getAll() {

        return this.collection.values();
    }

    deleteById(id) {


        if (id && this.collection.has(id)) {

            let temp = this.collection.get(id);
            this.collection.delete(id);

            return temp;
        }

        console.log("Id not found!");

        return null;
    }

    replaceById(id, obj) {

        if (obj && id && typeof (obj) == 'object') {

            if (this.collection.has(id)) {

                this.collection.set(id, obj);
                return true;
            } else {

                console.log("ID not found!")
            }
        }

        return false;
    }

    updateById(id, obj) {

        if (!obj || !id || typeof (obj) != 'object') {

            return null;
        }

        if (!this.collection.has(id)) {

            console.log("ID not found!");
            return null;

        } else {

            
            this.collection.delete(id);
            this.collection.set(id, obj);

        }

        return true;
    }
}
