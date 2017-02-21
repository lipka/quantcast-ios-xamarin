all:
	$(MAKE) -C library
	cp library/libQuantcast.a binding/libQuantcast.a
	$(MAKE) -C binding

clean:
	$(MAKE) -C library clean
	$(MAKE) -C binding clean
