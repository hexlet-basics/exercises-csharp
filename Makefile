-include /opt/basics/common/common.mk

compose-setup: compose-build

compose:
	docker-compose up

compose-build:
	docker-compose build

code-lint:
	~/bin/jb inspectcode Program.csproj

compile:
	@(for i in $$(find . -type f -name Program.csproj); do dotnet build $$(dirname $$i)/*.csproj ; done)

clean:
	@$$(find . -type f -name *.cs -delete)

compose-bash:
	docker-compose run exercises bash

compose-test:
	docker-compose run exercises make test
