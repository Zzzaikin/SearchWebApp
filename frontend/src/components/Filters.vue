



<template>
  <div class="filters">
    <div class="ml-5">
      <v-row class="ma-0">
        <v-checkbox
          v-model="selected"
          label="Нет пилотного проекта"
          value="1"
        ></v-checkbox>
        <v-checkbox
          class="ml-6"
          v-model="selected"
          label="Есть пилотный проект"
          value="2"
        ></v-checkbox>
      </v-row>
    </div>
    <div class="filters">
      <div class="filters-group" id="hasPilotProject">
        <div class="filter-label ml-5">
          <span>Заявка</span>
        </div>
        <v-row class="ma-0">
          <v-col>
            <v-select
              outlined
              multiple
              v-model="f1"
              class="filter mx-2"
              :items="[
                'Машинное обучение',
                'Веб-приложение',
                'Базы данных',
                'Виртуальная реальность',
                'Облачные хранилища',
                'Блокчейн',
                'Инфокоммуникационные технологии',
              ]"
              label="Технология"
            ></v-select>
          </v-col>

          <v-col>
            <v-select
              outlined
              multiple
              v-model="f3"
              class="filter mx-2"
              :items="[
                'Общество и благосфера',
                'Строительство',
                'Финансы',
                'Робототехника',
                'Энергетика',
                'Машиностроение',
                'Сельское хозяйство',
              ]"
              label="Предметная область"
            ></v-select>
          </v-col>
        </v-row>
        <v-row class="ma-0">
          <v-col>
            <v-select
              outlined
              multiple
              v-model="f1"
              class="filter mx-2"
              :items="[
                'Скрининг',
                'Скоринг',
                'Экспертный совет',
                'Акселерационная программа',
                'Программа пилотирования',
                'Инвестирование',
              ]"
              label="Стадия готовности"
            ></v-select>
          </v-col>

          <v-col>
            <v-select
              outlined
              multiple
              v-model="f3"
              class="filter mx-2"
              :items="['1-5', '6-10', '11-15', '16-20', '21-26', '27+']"
              label="Сколько человек в организации"
            ></v-select>
          </v-col>
        </v-row>

        <div class="filter-label ml-5" v-if="hasPilotProject">
          <span>Пилотный проект</span>
        </div>
        <v-row class="ma-0" v-if="hasPilotProject">
          <v-col>
            <v-select
              outlined
              multiple
              v-model="f4"
              class="filter mx-2"
              :items="['В работе', 'Приостановлен', 'Закрыт', 'Отменен']"
              label="Состояние проекта"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              v-model="f5"
              multiple
              class="filter mx-2"
              :items="[
                'Позиционирование в ОТКМ',
                'Детализация параметров пилотного тестирования',
                'Подготовка к пилотному тестированию',
                'Проведение пилотного тестирования',
                'Формирование отчёта пилотном тестировании',
                'Закрытие пилотного проекта',
                'Закрыт',
              ]"
              label="Фаза пилотного тестирования"
            ></v-select>
          </v-col>
        </v-row>
      </div>
    </div>
    <div class="buttons pa-5">
      <v-row class="ma-0">
        <v-btn color="primary" @click="applyFilters"> Применить </v-btn>
        <v-btn outlined class="ml-6" @click="cancelFilters"> Сбросить </v-btn>
      </v-row>
    </div>
  </div>
</template>

<script>
export default {
  props: ["value"],
  data: () => ({
    selected: [],
    items: ["Значение 1", "Значение 2", "Значение 3"],
    defaultLabel: "Фильтр",
    f1: [],
    f2: [],
    f3: [],
    f4: [],
    f5: [],
  }),
  computed: {
    hasPilotProject() {
      return this.selected.includes("2");
    },
    oneSelected() {
      return this.selected.length > 0;
    },
  },
  methods: {
    cancelFilters() {
      this.f1 = [];
      this.f2 = [];
      this.f3 = [];
      this.f4 = [];
      this.f5 = [];
      this.selected = [];
    },
    applyFilters() {
      this.filters = {
        f1: this.f1,
        f2: this.f2,
        f3: this.f3,
        f4: this.f4,
        f5: this.f5,
      };
      this.$emit("input", this.filters);
      this.$emit("closeMenu");
    },
  },
};
</script>











