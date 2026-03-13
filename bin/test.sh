#!/usr/bin/env bash

# TODO: при возникновении ошибок компиляции в подключаемых файлах с помощью #load
# выполнение скрипта завершается с кодом 0, то есть не считается ошибкой.
# Нужно найти грамотное решение. Временное решение с помощью bash:

OUTPUT=$(dotnet-script Test.csx 2>&1)
exit_code=$?
printf '%s\n' "$OUTPUT"

if [ "$exit_code" -ne 0 ]; then
  exit "$exit_code"
fi

! grep -q 'error CS' <<<"$OUTPUT"
