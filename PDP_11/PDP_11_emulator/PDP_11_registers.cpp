#include "PDP_11_registers.h"
#include <string.h>
#include "stdafx.h"

status_t PDP_11_registers_init(PDP_11_registers* registers) {
	registers->R0 = 0x0000;
	registers->R1 = 0x0000;
	registers->R2 = 0x0000;
	registers->R3 = 0x0000;
	registers->R4 = 0x0000;
	registers->R5 = 0x0000;
	registers->SP = 0x0000;
	registers->PC = 0x0000;
	registers->MW = 0x0000;

	return 0;
}

status_t PDP_11_registers_read_register(char* name, PDP_11_registers* registers, short* buffer) {
	if (!strcmp(name, "R0")) {
		*buffer = registers->R0;
	} 
	else if (!strcmp(name, "R1")) {
		*buffer = registers->R1;
	}
	else if (!strcmp(name, "R2")) {
		*buffer = registers->R2;
	}
	else if (!strcmp(name, "R3")) {
		*buffer = registers->R3;
	}
	else if (!strcmp(name, "R4")) {
		*buffer = registers->R4;
	}
	else if (!strcmp(name, "R5")) {
		*buffer = registers->R5;
	}
	else if (!strcmp(name, "SP")) {
		*buffer = registers->SP;
	}
	else if (!strcmp(name, "PC")) {
		*buffer = registers->PC;
	}

	return 0;
}

status_t PDP_11_registers_write_register(char* name, PDP_11_registers* registers, short buffer) {
	if (!strcmp(name, "R0")) {
		registers->R0 = buffer;
	}
	else if (!strcmp(name, "R1")) {
		registers->R1 = buffer;
	}
	else if (!strcmp(name, "R2")) {
		registers->R2 = buffer;
	}
	else if (!strcmp(name, "R3")) {
		registers->R3 = buffer;
	}
	else if (!strcmp(name, "R4")) {
		registers->R4 = buffer;
	}
	else if (!strcmp(name, "R5")) {
		registers->R5 = buffer;
	}
	else if (!strcmp(name, "SP")) {
		registers->SP = buffer;
	}
	else if (!strcmp(name, "PC")) {
		registers->PC = buffer;
	}

	return 0;
}

status_t PDP_11_registers_read_flag(char* name, PDP_11_registers* registers, char* value) {
	if (!strcmp(name, "OF")) {
		if (!value) registers->MW &= 0xFFFE;
		else registers->MW |= 0x0001;
	}
	else if (!strcmp(name, "CF")) {
		if (!value) registers->MW &= 0xFFFD;
		else registers->MW |= 0x0002;
	}
	else if (!strcmp(name, "ZF")) {
		if (!value) registers->MW &= 0xFFFB;
		else registers->MW |= 0x0004;
	}
	else if (!strcmp(name, "SF")) {
		if (!value) registers->MW &= 0xFFF7;
		else registers->MW |= 0x0008;
	}

	return 0;
}

status_t PDP_11_registers_write_flag(char* name, PDP_11_registers* registers, char value) {
	if (!strcmp(name, "OF")) {
		if (registers->MW & 0x0001) value = 1;
		else value = 0;
	}
	else if (!strcmp(name, "CF")) {
		if (registers->MW & 0x0002) value = 1;
		else value = 0;
	}
	else if (!strcmp(name, "ZF")) {
		if (registers->MW & 0x0004) value = 1;
		else value = 0;
	}
	else if (!strcmp(name, "SF")) {
		if (registers->MW & 0x0008) value = 1;
		else value = 0;
	}

	return 0;
}